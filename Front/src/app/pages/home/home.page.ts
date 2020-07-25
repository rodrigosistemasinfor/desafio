import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario.service';
import { UsuarioSeletor } from 'src/app/seletor/usuario.seletor';
import { UsuarioModel } from 'src/app/model/usuario.model';
import { ToastrManager  } from 'ng6-toastr-notifications';
import { Router } from '@angular/router';

@Component({
  selector: 'home-page',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.css']
})
export class HomePage implements OnInit {

  seletor: UsuarioSeletor = new UsuarioSeletor();
  seletorFiltros: UsuarioSeletor = new UsuarioSeletor();
  public listaUsers: UsuarioModel[] = [];

  constructor(
     private _service: UsuarioService,
     public toastr: ToastrManager,
     private _router: Router ) { }

  ngOnInit() {

   this.loadUsers();
  }

  private loadUsers(){
    this.seletor.RegistroPorPagina = 100;
    this._service.list(this.seletor)
       .subscribe(x => {
          this.listaUsers = x.Data;
       },
       error => {
         console.log(error);
         this.toastr.errorToastr("Ocorreu um erro em sua solicitação");
       })
  }

  deletar(){
    this._service.delete(this.seletorFiltros).subscribe(response => {
      this.toastr.successToastr("usuario apagado");
      this.loadUsers();
    }
    ,erro=>{
          console.log(erro);
          this.toastr.errorToastr("Erro ao apagar o user");
    });
  }

  private getUsers(){
    this.seletorFiltros.RegistroPorPagina = 100;
    this._service.list(this.seletorFiltros)
       .subscribe(x => {
          this.listaUsers = x.Data;
       },
       error => {
         console.log(error);
         this.toastr.errorToastr("Ocorreu um erro em sua solicitação");
       })
  }
}
