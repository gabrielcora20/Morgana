import { Component, OnInit } from '@angular/core';
import { Palavra } from 'src/app/interfaces/palavra';
import { AppService } from 'src/app/services/app.service';

@Component({
  selector: 'app-palavra',
  templateUrl: './palavra.component.html',
  styleUrls: ['./palavra.component.css']
})
export class PalavraComponent implements OnInit {

  displayedColumns: string[] = [ 'denominacao', 'classeGramatical', 'origem', 'significado'];
  palavras: Palavra[];

  constructor(private service: AppService) { }

  ngOnInit(): void {
    this.palavras = this.service.obtemPalavras();
  }

}
