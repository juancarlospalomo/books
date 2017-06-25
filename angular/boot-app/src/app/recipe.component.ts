import { Component } from "@angular/core";
import { Recipe } from "./recipe";
import { RecipeService } from "./recipe.service";
import { OnInit } from "@angular/core";

@Component({
  selector: "recipes",
  template: `
    <div>
      <h2>Recipes list</h2>
      <ul class="recipes">
        <li *ngFor="let recipe of recipes" 
                [class.selected] = "recipe === selectedRecipe"
                (click)="onSelect(recipe)">
          <span class="badge">{{recipe.id}}</span><span class="text">{{recipe.name}}</span>
        </li>
      </ul>
      <recipe-detail class="recipe-detail" [recipe]="selectedRecipe"></recipe-detail>  
    </div>
    `,
  styleUrls: ["./recipe.component.css"]
})

export class RecipeComponent implements OnInit {
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
