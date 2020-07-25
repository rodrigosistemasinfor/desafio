import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { HomePage } from './pages/home/home.page';
import {  CadastroPage } from './pages/cadastro/cadastro.page';

const appRoutes: Routes = [
  { path: '', redirectTo: 'home',  pathMatch: 'full'},
  { path: 'home', component:  HomePage},
  { path: 'cadastro', component:  CadastroPage},
  { path: 'cadastro/:id', component:  CadastroPage}
];

@NgModule({
  imports: [
    RouterModule.forRoot(appRoutes)
  ],
  exports: [RouterModule]
})
export class Routing { }