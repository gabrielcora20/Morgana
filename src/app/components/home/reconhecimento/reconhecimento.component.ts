import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { AppService } from 'src/app/shared/services/app-service.service';

@Component({
  selector: 'app-reconhecimento',
  templateUrl: './reconhecimento.component.html',
  styleUrls: ['./reconhecimento.component.css']
})
export class ReconhecimentoComponent implements OnInit {

  @ViewChild('containerResposta') private containerResposta: ElementRef;

  showSearchButton: boolean;
  speechData: Array<string>;

  public listaFrases: Array<string>

  constructor(private svc: AppService) {
    // this.showSearchButton = true;
    this.speechData = [
      'Olá, sou a Morgana, estou ouvindo'
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a',
      // 'a'
    ];
  }

  ngOnInit() {
    this.activateSpeech();
  }

  ngAfterViewChecked() {        
    this.scrollToBottom();        
  } 

  scrollToBottom(): void {
      try {
          this.containerResposta.nativeElement.scrollTop = this.containerResposta.nativeElement.scrollHeight;
      } catch(err) { }                 
  }

  ngOnDestroy() {
    this.svc.paraReconhecimentoPorVoz();
  }

  activateSpeech(): void {
    // this.showSearchButton = false;

    this.svc.iniciaReconhecimentoPorVoz()
    .subscribe(
      //listener
      (value) => {  
        this.speechData.push(value);
        // console.log(this.speechData);
      },
      //errror
      (err) => {
        console.log(err);
        if (err.error == "no-speech") {
          console.log("--restatring service--");
          this.activateSpeech();
        }
      },
      //completion
      () => {
        this.showSearchButton = true;
        console.log("--complete--");
        this.activateSpeech();
      });
  }
}
