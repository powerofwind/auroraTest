import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { interest } from '../../models/interest';

@Component({
  selector: 'page-list',
  templateUrl: 'list.html'
})
export class ListPage {
  
  public interest: interest[];
  
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }
}
