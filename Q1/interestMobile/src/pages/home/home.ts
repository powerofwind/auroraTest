import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { ListPage } from '../list/list';
import { HttpClient } from '@angular/common/http';
import { interest } from '../../models/interest';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  public Interest: number;
  public money: number;
  public yearcount: number;

  constructor(public navCtrl: NavController, public http: HttpClient) {
   
  }

  send(){
  this.http.post("https://localhost:5001/api/Interest",
  {
    Interest: this.Interest,
    money: this.money,
    yearcount: this.yearcount,

  }).subscribe(
    it => {
      console.log('success')
    },
    );
  }

  nextpage() {
    this.navCtrl.push(ListPage)
  }

}
