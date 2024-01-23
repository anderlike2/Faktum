import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable, OperatorFunction } from 'rxjs';
import { debounceTime, distinctUntilChanged, filter, map, tap } from 'rxjs/operators';
import { IListCombo } from 'src/app/models/general.model';
import { IProducto } from 'src/app/models/producto.model';
import { CargueCombosService } from 'src/app/services/cargue-combos-service/cargue-combos.service';
import { ProductoService } from 'src/app/services/producto-service/producto.service';
import { IDetalleFactura } from 'src/app/models/facturacion.model';

@Component({
  selector: 'app-agregar-producto',
  templateUrl: './agregar-producto.component.html',
  styleUrls: ['./agregar-producto.component.scss']
})
export class AgregarProductoComponent implements OnInit {

  @Input() facturaData!: any;
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
    private modalRef: NgbActiveModal
  ) { }

  ngOnInit(): void {
    this.init();
  }

  init(): void {
    this.obtenerProductos();
    this.cargarComboListas();
    this.initForm();
  }

  obtenerProductos(): void {

    this.productoService.obtenerProductosPorEmpresaid(this.facturaData.empresaId).subscribe({
      next: (response) => this.listaProducto = response
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
      detaPorcIva: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaIva: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaPorcCrf: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaValRf: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaValReteIca: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaValor: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaTipoImpuestoId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ],
      detaListaPreciosId: [ { value: '', disabled: false }, [
          Validators.required
        ]
      ]
    };

    this.productoFormGroup = this.fb.group(formControls);
  }

  formatterResult = (product: IProducto) => {
    return product.prodNombreFactura;
  }
  formatterInput = (product: IProducto) => {
    const control = this.productoFormGroup.get('detaFactCodigo');
    const controlMarca = this.productoFormGroup.get('marca');
    const controlModelo = this.productoFormGroup.get('modelo');
    this.producto = product;
    control.setValue(product.prodCodigo);
    controlMarca.setValue(product.prodMarca);
    controlModelo.setValue(product.prodModelo);

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
      if (!control.value) {
        control.setValue('');
        controlCodigo.setValue('');
        controlMarca.setValue('');
        controlModelo.setValue('');
        this.listaPrecioLista = [];
        this.producto = null;
      }
    }

    adicionarProducto(): void {
      if (this.productoFormGroup.invalid) {
        this.productoFormGroup.markAllAsTouched();
        return;
      }

      const formData = this.productoFormGroup.getRawValue();

      // const detalleProducto: IDetalleFactura = {

      // };


    }

    cerrarModal(info?: any) {
      this.modalRef.close(info);
    }

}
