import { Component } from "@angular/core";
import { Recipe } from "./recipe";
import { RecipeService } from "./recipe.service";
import { OnInit } from "@angular/core";

@Component({
  selector: "app-root",
  template: `
    <h1>{{title}}</h1>
    <h2>Recipes list</h2>
    <ul class="recipes">
      <li *ngFor="let recipe of recipes" 
              [class.selected] = "recipe === selectedRecipe"
              (click)="onSelect(recipe)">
        <span class="badge">{{recipe.id}}</span><span class="text">{{recipe.name}}</span>
      </li>
    </ul>
    <div *ngIf="selectedRecipe">
      <recipe-detail [recipe]="selectedRecipe"></recipe-detail>
    </div>
    `,
  styleUrls: ["./app.component.css"]
})
export class AppComponent implements OnInit {
  title = "Boot App";
  selectedRecipe: Recipe;
  recipes: Recipe[];

  constructor(private recipeService: RecipeService) {}

  getRecipes(): void {
    this.recipeService.getRecipes().then(recipes => (this.recipes = recipes));
  }

  onSelect(recipe: Recipe): void {
    this.selectedRecipe = recipe;
  }

  ngOnInit(): void {
    this.getRecipes();
  }
}
