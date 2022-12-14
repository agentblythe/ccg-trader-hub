import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'CCG Trader Hub';
  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get("https://localhost:5000/api/users").subscribe(
      response => this.users = response,
      error => console.log(error),
    )
  }
}
