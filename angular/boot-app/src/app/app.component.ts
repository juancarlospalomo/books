import { Component } from "@angular/core";

@Component({
  selector: "app-root",
  template: `
    <md-toolbar color="primary">
      {{title}}
      <md-toolbar-row>
        <span>Second line</span>
        <span class="menu-item-spacer"></span>
        <md-icon class="material-icons">account_circle</md-icon>
      </md-toolbar-row>
    </md-toolbar>
    
    <h1>{{title}}</h1>
    <nav>
        <a routerLink="/dashboard">Dashboard</a>
        <a routerLink="/recipes">Recipes</a>
    </nav>
    <router-outlet></router-outlet>
  `,
  styleUrls: ['app.component.css']
})
export class AppComponent {
  title = "Recipes App";
}
