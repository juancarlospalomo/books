import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "app-root",
  templateUrl: "app.component.html",
  styleUrls: ["app.component.css"]
})
export class AppComponent {
  title = "Recipes App";
  constructor(private router: Router) {}

  navigate = function(path: string) {
    this.router.navigateByUrl(path);
  };
}
