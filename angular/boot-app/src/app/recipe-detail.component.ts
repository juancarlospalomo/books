import { Component, Input } from "@angular/core";
import { Recipe } from "./recipe";

@Component({
  selector: "recipe-detail",
  template: `
        <div *ngIf="recipe">
            <h2>{{recipe.name}}</h2>
            <img src="{{recipe.image}}" />
        </div>
    `
})

export class RecipeDetailComponent {
  @Input() recipe: Recipe;
}
