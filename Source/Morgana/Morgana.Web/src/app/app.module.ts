import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReconhecimentoComponent } from './components/home/reconhecimento/reconhecimento.component';
import { SpeechRecognitionService } from './shared/services/speech-recognition.service';
import { AppService } from './shared/services/app-service.service';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    ReconhecimentoComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule    
  ],
  providers: [
    AppService,
    SpeechRecognitionService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
