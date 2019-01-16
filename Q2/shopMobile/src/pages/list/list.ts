import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { CartPage } from '../cart/cart';
import { products } from '../../models/products';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {

  public allproduct: products;
  public Name: string;
  public Amount: number;

  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
    this.ionViewDidLoad()
  }

  ionViewDidLoad() {
    this.http.get<products>("https://localhost:5001/api/Shop").subscribe(
      it => {
        this.allproduct = it;
        console.log(this.allproduct);
      },
      error => {
        // ERROR: Do something
      });
  }

  order() {
    this.http.post("https://localhost:5001/api/Order",
      {
        Name: this.Name,
        Amount: this.Amount

      }).subscribe(
        it => {
          console.log('ordersuccess')
        },
        error => {
          // ERROR: Do something
        });
  }

  // refreshPage(){
  //   this.http.get<products>("https://localhost:5001/api/Shop").subscribe(
  //     it => {
  //       this.allproduct = it;
  //     });
  //   }

  cart() {
    this.navCtrl.push(CartPage)
  }
}