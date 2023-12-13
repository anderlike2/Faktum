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
    title: 'menu Faktum',
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
            title: 'Empresa detalle',
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
          }
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
            title: 'Sucursal detalle',
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
            title: 'Cliente detalle',
            type: 'item',
            url: '/gestion-cliente/detalle-cliente',
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
