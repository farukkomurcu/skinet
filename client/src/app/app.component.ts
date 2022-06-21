import { Component, OnInit } from '@angular/core';
import { BasketService } from './basket.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit { 
  title = 'Skinet';
 
  constructor(private basketService: BasketService){}

  ngOnInit(): void {  
    const basketId=localStorage.getItem('basket_id');
    this.basketService.getBasket(basketId).subscribe(()=>{
      console.log('initialised basket');
    }, error=>{
      console.log(error)
    });     
  }  
}
