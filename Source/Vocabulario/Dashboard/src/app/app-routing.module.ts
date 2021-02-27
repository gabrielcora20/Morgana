import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FraseComponent } from './components/frase/frase.component';
import { HomeComponent } from './components/home/home.component';
import { PalavraComponent } from './components/palavra/palavra.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'frases', component: FraseComponent },
  { path: 'palavras', component: PalavraComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
