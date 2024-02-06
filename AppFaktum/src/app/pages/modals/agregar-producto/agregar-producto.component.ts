import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable, OperatorFunction, pipe } from 'rxjs';
import { debounceTime, distinctUntilChanged, filter, map, tap } from 'rxjs/operators';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto } from 'src/app/models/producto.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { IDetalleFactura } from 'src/app/models/facturacion.model';
import { ListaPrecioProductoService } from 'src/app/services/lista-precio-producto-service/lista-precio-producto.service';

@Component({
  selector: 'app-agregar-producto',
  templateUrl: './agregar-producto.component.html',
  styleUrls: ['./agregar-producto.component.scss']
})
export class AgregarProductoComponent implements OnInit {

  @Input() facturaData!: any;
  @Input() listaPreciosId!: number;
  producto!: IProducto;

  productoFormGroup: FormGroup;
  fb = new FormBuilder();

  listaProducto: any[] = [];
  listaUnidadMedida: IListCombo[] = [];
  listaTipoImpuesto: IListCombo[] = [];
  listaPrecioLista: IListCombo[] = [];

  constructor(
    private productoService: ProductoService,
    private cargueCombosService: CargueCombosService,
    private modalRef: NgbActiveModal,
    private listaPrecioProductoService: ListaPrecioProductoService
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.obtenerProductos();
    this.cargarComboListas();
    this.initForm();
    this.actionControls();
  }

  obtenerProductos(): void {

    this.listaPrecioProductoService.obtenerProductosPorListaPrecio(this.listaPreciosId)
    .pipe(
      map((response) =>
        response?.map((item) => ({
          id: item.lproProducto.id,
          prodNombreFactura: item.lproProducto.prodNombreFactura,
          prodCodigo: item.lproProducto.prodCodigo,
          prodMarca: item.lproProducto.prodMarca,
          prodModelo: item.lproProducto.prodModelo,
          prodValorUnitarioLP: item.lproValor,
          listaPrecioId: item.lproListaPrecioId
        })))
    )
    .subscribe({
      next: (response) => {
        this.listaProducto = response;
      }
    });

  }

  actionControls(): void {

    this.productoFormGroup.get('detaCantidad').valueChanges.subscribe({
      next: (value) => {
        if (value) {
          const controlValorUnitario = this.productoFormGroup.get('detaValorUnitario').value;
          const valor = +value * +controlValorUnitario;
           this.productoFormGroup.get('detaValor').setValue(valor);
        }
      }
    });

    this.productoFormGroup.get('detaValorUnitario').valueChanges.subscribe({
      next: (value) => {
        if (value) {
          const controlCantidad = this.productoFormGroup.get('detaCantidad').value;
          const valor = +value * +controlCantidad;
           this.productoFormGroup.get('detaValor').setValue(valor);
        }
      }
    });

    this.productoFormGroup.get('detaPorDescuento').valueChanges.subscribe({
      next: (value) => {
        let total = 0;
        if (value) {
          const controlCantidad = this.productoFormGroup.get('detaCantidad').value;
          const controlValorUnitario = this.productoFormGroup.get('detaValorUnitario').value;
          const valor = +controlCantidad * +controlValorUnitario;
          total = valor - ((valor * value) / 100);
        } else {
          const controlCantidad = this.productoFormGroup.get('detaCantidad').value;
          const controlValorUnitario = this.productoFormGroup.get('detaValorUnitario').value;
          total = +controlCantidad * +controlValorUnitario;
        }

        this.productoFormGroup.get('detaValor').setValue(total);
      }
    });

    this.productoFormGroup.get('detaPorcIva').valueChanges.subscribe({
      next: (value) => {
        this.productoFormGroup.get('detaPorDescuento').updateValueAndValidity();
        if (value) {
          const controlTotal = this.productoFormGroup.get('detaValor').value;
          const valor = (+controlTotal * +value) / 100;
          const total = controlTotal + valor;

          this.productoFormGroup.get('detaIva').setValue(valor, { emitEvent: false });
          this.productoFormGroup.get('detaValor').setValue(total);
        } else {
          this.productoFormGroup.get('detaIva').setValue('', { emitEvent: false });
        }
      }
    });

    this.productoFormGroup.get('detaIva').valueChanges.subscribe({
      next: (value) => {
        this.productoFormGroup.get('detaPorDescuento').updateValueAndValidity();
        if (value) {
          const controlTotal = this.productoFormGroup.get('detaValor').value;
          const valor = (+value * 100) / +controlTotal;
          const total = controlTotal + value;

          this.productoFormGroup.get('detaPorcIva').setValue(valor, { emitEvent: false });
          this.productoFormGroup.get('detaValor').setValue(total);
        } else {
          this.productoFormGroup.get('detaPorcIva').setValue('', { emitEvent: false });
        }
      }
    });

    this.productoFormGroup.get('detaPorcCrf').valueChanges.subscribe({
      next: (value) => {
        this.productoFormGroup.get('detaPorDescuento').updateValueAndValidity();
        if (value) {
          const controlTotal = this.productoFormGroup.get('detaValor').value;
          const valor = (+controlTotal * +value) / 100;
          this.productoFormGroup.get('detaIva').updateValueAndValidity();
          const valTotalIva = this.productoFormGroup.get('detaValor').value;
          const total = valTotalIva + valor;

          this.productoFormGroup.get('detaValRf').setValue(valor, { emitEvent: false });
          this.productoFormGroup.get('detaValor').setValue(total);
        } else {
          this.productoFormGroup.get('detaIva').updateValueAndValidity();
          this.productoFormGroup.get('detaValRf').setValue('', { emitEvent: false });
        }
      }
    });

    this.productoFormGroup.get('detaValRf').valueChanges.subscribe({
      next: (value) => {
        this.productoFormGroup.get('detaPorDescuento').updateValueAndValidity();
        if (value) {
          const controlTotal = this.productoFormGroup.get('detaValor').value;
          const valor = (+value * 100) / +controlTotal;
          this.productoFormGroup.get('detaIva').updateValueAndValidity();
          const valTotalIva = this.productoFormGroup.get('detaValor').value;
          const total = valTotalIva + value;

          this.productoFormGroup.get('detaPorcCrf').setValue(valor, { emitEvent: false });
          this.productoFormGroup.get('detaValor').setValue(total);
        } else {
          this.productoFormGroup.get('detaIva').updateValueAndValidity();
          this.productoFormGroup.get('detaPorcCrf').setValue('', { emitEvent: false });
        }
      }
    });

    this.productoFormGroup.get('detaValReteIca').valueChanges.subscribe({
      next: (value) => {
        this.productoFormGroup.get('detaPorDescuento').updateValueAndValidity();
        this.productoFormGroup.get('detaValRf').updateValueAndValidity();
        if (value) {
          const valTotalIva = this.productoFormGroup.get('detaValor').value;
          const total = valTotalIva - value;

          this.productoFormGroup.get('detaValor').setValue(total);
        }
      }
    });

  }

  cargarComboListas(): void {
    this.cargueCombosService.obtenerListaUnidadesEmpresa(this.facturaData.empresaId).subscribe({
      next: (response) => this.listaUnidadMedida = response
    });

    this.cargueCombosService.obtenerListaTablaImpuestos().subscribe({
      next: (response) => this.listaTipoImpuesto = response
    });
  }

  initForm(): void {
    const formControls: { [key: string]: any } = {
      detaFactCodigo: [ { value: '', disabled: true }, [
          Validators.required
        ]
      ],
      detaDescripcion: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      // detaProducto: [ { value: '', disabled: false }, [
      //     Validators.required
      //   ]
      // ],
      marca: [ { value: '', disabled: true }, [] ],
      modelo: [ { value: '', disabled: true }, [] ],
      detaOrdenCompra: [ { value: '', disabled: false }, [] ],
      detaRemision: [ { value: '', disabled: false }, [] ],
      detaUnidadId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaCantidad: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaValorUnitario: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaPorDescuento: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaPorcIva: [ { value: 0, disabled: false }, [
          Validators.required
        ]
      ],
      detaIva: [ { value: 0, disabled: false }, [
          Validators.required
        ]
      ],
      detaPorcCrf: [ { value: 0, disabled: false }, [
          Validators.required
        ]
      ],
      detaValRf: [ { value: 0, disabled: false }, [
          Validators.required
        ]
      ],
      detaValReteIca: [ { value: 0, disabled: false }, [
          Validators.required
        ]
      ],
      detaValor: [ { value: '', disabled: true }, [
          Validators.required
        ]
      ],
      detaTipoImpuestoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaLinea: [ { value: null, disabled: false }, [
        Validators.required
      ]
      ]
    };

    this.productoFormGroup = this.fb.group(formControls);
  }

  get detaFactCodigoErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaFactCodigo') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaDescripcionErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaDescripcion') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaUnidadIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaUnidadId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaCantidadErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaCantidad') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaValorUnitarioErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaValorUnitario') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaPorDescuentoErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaPorDescuento') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaPorcIvaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaPorcIva') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaIvaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaIva') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaPorcCrfErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaPorcCrf') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaValRfErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaValRf') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaValReteIcaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaValReteIca') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaValorErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaValor') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaTipoImpuestoIdErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaTipoImpuestoId') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }
  get detaLineaErrorMensaje(): string {
    const form: AbstractControl = this.productoFormGroup.get('detaLinea') as AbstractControl;
    return form.hasError('required')
      ? 'Campo obligatorio' : '';
  }

  formatterResult = (product: IProducto) => {
    return product.prodNombreFactura;
  }

  formatterInput = (product: any) => {
    const control = this.productoFormGroup.get('detaFactCodigo');
    const controlMarca = this.productoFormGroup.get('marca');
    const controlModelo = this.productoFormGroup.get('modelo');
    const controlValUnitario = this.productoFormGroup.get('detaValorUnitario');
    this.producto = product;
    control.setValue(product.prodCodigo);
    controlMarca.setValue(product.prodMarca);
    controlModelo.setValue(product.prodModelo);
    controlValUnitario.setValue(product.prodValorUnitarioLP);

    if (product) {
      this.cargueCombosService.obtenerListaPreciosProducto(product.id).subscribe({
        next: (response) => this.listaPrecioLista = response
      });
    }

    return product.prodNombreFactura;
  }

  search: OperatorFunction<string, readonly { prodNombreFactura; prodCodigo }[]> = (text$: Observable<string>) =>
		text$.pipe(
			debounceTime(200),
			distinctUntilChanged(),
			filter((term) => term.length >= 2),
			map((term) => this.listaProducto?.filter((product) =>
        new RegExp(term, 'mi').test(product.prodNombreFactura) ||
        new RegExp(term, 'mi').test(product.prodCodigo)
      ).slice(0, 10)),
		);

    onBlurFormat() {
      const control = this.productoFormGroup.get('detaDescripcion');
      const controlCodigo = this.productoFormGroup.get('detaFactCodigo');
      const controlMarca = this.productoFormGroup.get('marca');
      const controlModelo = this.productoFormGroup.get('modelo');
      const controlValUnitario = this.productoFormGroup.get('detaValorUnitario');
      if (!control.value) {
        control.setValue('');
        controlCodigo.setValue('');
        controlMarca.setValue('');
        controlModelo.setValue('');
        controlValUnitario.setValue('');
        this.listaPrecioLista = [];
        this.producto = null;
      }
    }

    adicionarProducto(): void {
      console.log(this.productoFormGroup);
      if (this.productoFormGroup.invalid) {
        this.productoFormGroup.markAllAsTouched();
        return;
      }

      const formData = this.productoFormGroup.getRawValue();

      const detalleProducto: IDetalleFactura = {
        detaCantidad: formData.detaCantidad,
        detaOrdenCompra: formData.detaOrdenCompra,
        detaPorDescuento: formData.detaPorDescuento,
        detaUnidadId: formData.detaUnidadId,
        detaTipoImpuestoId: formData.detaTipoImpuestoId,
        detaRemision: formData.detaRemision,
        detaPorcCrf: formData.detaPorcCrf,
        detaValRf: formData.detaValRf,
        detaPorcIva: formData.detaPorcIva,
        detaIva: formData.detaIva,
        detaValReteIca: formData.detaValReteIca,
        detaValorUnitario: formData.detaValorUnitario,
        detaValor: formData.detaValor,
        detaCentroCostos: this.producto.prodCentroCostoId,
        detaDescripcion: this.producto.prodNombreFactura,
        detaFactCodigo: this.producto.prodCodigo,
        detaProducto: this.producto.id,
        detaListaPrecio: this.producto.prodListaPrecio?.toString(),
        detaEmpresaId: this.producto.prodEmpresaId,
        detaRetefuenteId: this.producto.prodCodReteFuenteId,
        estado: 1,
        detaFechaDespacho: new Date().toISOString(),
        detaListaPreciosId: this.producto.prodListaPrecio,
        detaLinea: formData.detaLinea,
        detaFacturaId: this.facturaData.facturaId
      };

      this.cerrarModal(detalleProducto);
    }

    cerrarModal(info?: any) {
      this.modalRef.close(info);
    }

}
