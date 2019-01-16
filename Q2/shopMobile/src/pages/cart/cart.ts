import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { products } from '../../models/products';
import { order } from '../../models/order';

@IonicPage()
@Component({
  selector: 'page-cart',
  templateUrl: 'cart.html',
})
export class CartPage {

  public orderProduct: order[];
  public sumTotal: number = 0 ;


  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
  }

  ionViewDidLoad() {
    this.http.get<order[]>("https://localhost:5001/api/Order").subscribe(
      it => {
        this.orderProduct = it;
        this.calculate(this.orderProduct);
      },
    );
  }

   calculate(data: order[]) {
    for (var i = 0; i < data.length; i++) {
      this.sumTotal += data[i].total;
    }
  }



}
