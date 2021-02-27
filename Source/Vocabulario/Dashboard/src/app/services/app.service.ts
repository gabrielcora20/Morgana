import { Injectable } from '@angular/core';
import { Palavra } from '../interfaces/palavra';
import { FraseService } from './frase.service';
import { PalavraService } from './palavra.service';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(
    private fraseService: FraseService,
    private palavraService: PalavraService,
  ) { }

  obtemFrases() {
    this.fraseService.consultaFrases();
  }

  obtemPalavras(): Palavra[] {
    return this.palavraService.consultaPalavras();
  }
}