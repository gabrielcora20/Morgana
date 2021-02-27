import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';
import { FraseComponent } from './components/frase/frase.component';
import { MatTableModule } from '@angular/material/table';
import { PalavraComponent } from './components/palavra/palavra.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FraseComponent,
    PalavraComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatTableModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
