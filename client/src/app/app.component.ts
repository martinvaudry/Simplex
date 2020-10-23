import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from './models/product';
import { IPagination} from './models/pagination';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss', ]
})
export class AppComponent implements OnInit {
  title = 'Simplex - Client';
  products: IProduct[];

  constructor(private Http: HttpClient) {}

  ngOnInit(): void {
   this.Http.get('https://localhost:5001/api/products?pagesSize=50').subscribe((response: IPagination) => {
     this.products = response.data;
   }, error => {
     console.log(error);
   });
  }
}
