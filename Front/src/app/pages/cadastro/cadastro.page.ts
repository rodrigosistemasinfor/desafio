import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsuarioModel } from 'src/app/model/usuario.model';
import { ToastrManager } from 'ng6-toastr-notifications';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'cadastro-page',
  templateUrl: './cadastro.page.html',
  styleUrls: ['./cadastro.page.css']
})
export class CadastroPage implements OnInit {

  constructor(private _router: Router,
              public toastr: ToastrManager,
              private usuarioService: UsuarioService) { }
  public user : UsuarioModel;

  ngOnInit() {
    this.user = new UsuarioModel();
  }

  salvar(){
    this.usuarioService.add(this.user)
        .subscribe(result=> {
          this.toastr.successToastr("Usuario cadastrado");
          this._router.navigate(["home"]);
        },
        erro=>{
          console.log(erro);
          this.toastr.errorToastr("Erro no cadastro");
        });
  }

}
