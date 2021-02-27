import { Injectable } from '@angular/core';
import { Palavra } from '../interfaces/palavra';

@Injectable({
  providedIn: 'root'
})
export class PalavraService {

  constructor() { }

  consultaPalavras(): Palavra[]{
    return [
      {_id: '1', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '2', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '3', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '4', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '5', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '6', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '7', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '8', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '9', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
      {_id: '10', classeGramatical: 'verbo', denominacao: 'cair', origem: 'não identificado', significado: 'teste'},
    ];;
  }
}
