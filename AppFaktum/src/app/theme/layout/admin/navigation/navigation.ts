import {Injectable} from '@angular/core';

export interface NavigationItem {
  id: string;
  title: string;
  type: 'item' | 'collapse' | 'group';
  translate?: string;
  icon?: string;
  hidden?: boolean;
  url?: string;
  classes?: string;
  exactMatch?: boolean;
  external?: boolean;
  target?: boolean;
  breadcrumbs?: boolean;
  function?: any;
  badge?: {
    title?: string;
    type?: string;
  };
  children?: Navigation[];
}

export interface Navigation extends NavigationItem {
  children?: NavigationItem[];
}

const NavigationItems = [
  {
    id: 'navigation',
    title: '',
    type: 'group',
    icon: 'feather icon-align-left',
    children: [
      {
        id: 'usuario',
        title: 'Usuario ',
        type: 'collapse',
        icon: 'fas fa-briefcase',
        children: [
          {
            id: 'detalle-usuario',
            title: 'Crear usuario',
            type: 'item',
            url: '/gestion-usuario/detalle-usuario',
            external: false
          }
        ]
      },
      {
        id: 'empresa',
        title: 'Empresa',
        type: 'collapse',
        icon: 'fas fa-building',
        children: [
          {
            id: 'detalle-empresa',
            title: 'Ver detalle',
            type: 'item',
            url: '/gestion-empresa/detalle-empresa',
            external: false
          },
          {
            id: 'crear-empresa',
            title: 'Crear empresa',
            type: 'item',
            url: '/gestion-empresa/crear-empresa',
            external: false
          },
          {
            id: 'centro-costos',
            title: 'Centro costos',
            type: 'item',
            url: '/gestion-empresa/centro-costos',
            external: false
          },
          {
            id: 'formatos-impresion',
            title: 'Formatos impresión',
            type: 'item',
            url: '/gestion-empresa/formatos-impresion',
            external: false
          },
          {
            id: 'unidades',
            title: 'Unidad',
            type: 'item',
            url: '/gestion-empresa/unidad',
            external: false
          },
          {
            id: 'otros-productos',
            title: 'Otros productos',
            type: 'item',
            url: '/gestion-empresa/otros-productos',
            external: false
          },
          {
            id: 'resoluciones',
            title: 'Resoluciones',
            type: 'item',
            url: '/gestion-empresa/resoluciones',
            external: false
          },
        ]
      },
      {
        id: 'sucursal',
        title: 'Sucursal',
        type: 'collapse',
        icon: 'fas fa-briefcase',
        children: [
          {
            id: 'detalle-sucursal',
            title: 'Ver detalle',
            type: 'item',
            url: '/gestion-sucursal/detalle-sucursal',
            external: false
          }
        ]
      },
      {
        id: 'cliente',
        title: 'Cliente',
        type: 'collapse',
        icon: "fas fa-portrait",
        children: [
          {
            id: 'detalle-cliente',
            title: 'Ver detalle',
            type: 'item',
            url: '/gestion-cliente/detalle-cliente',
            external: false
          }
        ]
      },
      {
        id: 'producto',
        title: 'Producto',
        type: 'collapse',
        icon: 'fas fa-briefcase',
        children: [
          {
            id: 'detalle-producto',
            title: 'Ver detalle',
            type: 'item',
            url: '/gestion-producto/detalle-producto',
            external: false
          }
        ]
      },
      {
        id: 'factura',
        title: 'Factura',
        type: 'collapse',
        icon: 'fas fa-portrait',
        children: [
          {
            id: 'crear-factura',
            title: 'Crear factura',
            type: 'item',
            url: '/factura/crear-factura',
            external: false
          }
        ]
      }
    ]
  }
];

@Injectable()
export class NavigationItem {
  public get() {
    return NavigationItems;
  }
}
