import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';

// import { CommonModule } from '@angular/common';

import { BookRoutingModule } from './book-routing.module';
import { BookComponent } from './book.component';


@NgModule({
  declarations: [
    BookComponent
  ],
  imports: [
    // CommonModule,//u can comment this as sharedmodule already exports it
    BookRoutingModule,
    SharedModule,
    NgbDatepickerModule
  ]
})
export class BookModule { }
