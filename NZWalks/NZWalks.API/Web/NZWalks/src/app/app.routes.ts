import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', redirectTo: '/walk', pathMatch: 'full' },
  {
    path: 'walk',
    loadChildren: () =>
      import('./module/walk/walk.routes').then((m) => m.walkRoutes),
  },
  {
    path: 'region',
    loadChildren: () =>
      import('./module/region/region.routes').then((m) => m.regionRoutes),
  },
];
