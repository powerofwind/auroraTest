import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { CartPage } from '../cart/cart';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {
  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CartPage');
  }
  cart(){
    this.navCtrl.push(CartPage)
  }
}