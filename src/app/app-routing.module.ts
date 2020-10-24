import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ReconhecimentoComponent } from './components/home/reconhecimento/reconhecimento.component';

const routes: Routes = [
  { path: '', component: ReconhecimentoComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }