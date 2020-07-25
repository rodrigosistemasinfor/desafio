import { UsuarioSeletor } from '../seletor/usuario.seletor';
import { UsuarioModel } from '../model/usuario.model';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { ResponseModelDomain } from '../domain/Response.model.domain';

@Injectable({
    providedIn: 'root'
})
export class UsuarioService{

    private endPoint: string;

    constructor(private http: HttpClient) {
        this.endPoint =  `${environment.ApiUrl}usuario`;
    }
    
    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    createEntity(input: any): UsuarioModel {
        return new UsuarioModel(input.data || input);
    }

     list(data: UsuarioSeletor): Observable<ResponseModelDomain<UsuarioModel>>{
        return this.http.post<any>(this.endPoint + "/list", data)
               .pipe(
                    map(res => {
                        const responseData  ={
                           Data : res.data.map(pp => this.createEntity(pp) as UsuarioModel),
                           TotalRows : res.count
                        }  as ResponseModelDomain<UsuarioModel>;
                    
                        return responseData;
                    })
                );
     }

     add(data: UsuarioModel): Observable<UsuarioModel>{
        return this.http.post<UsuarioModel>(this.endPoint, data, this.httpOptions);
     }

     delete(data: UsuarioSeletor){
        return this.http.post(this.endPoint+'/delete', data, this.httpOptions);
     }
}
