import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { ListPage } from '../list/list';
import { products } from '../../models/products';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  public Name: string;
  public Price: number;
  public Amount: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {
  }

  add() {
    this.http.post<products>("https://localhost:5001/api/Shop",
      {
        Name: this.Name,
        Price: this.Price,
        Amount: this.Amount

      }).subscribe(
        it => {
          console.log('success')
        },
        error => {
          // ERROR: Do something
        });
  }

  UpdateOrderHistory(productName: string,amount: number) {
    var url = "http://localhost:5000/api/Order/" + productName + amount;
    this.http.put(url,
      {
        Name: this.Name,
      }).subscribe(
        it => {
          // this.refreshPage();
          console.log('Update')
        });
  }

  shopping() {
    this.navCtrl.push(ListPage)
  }

}
