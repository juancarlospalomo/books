import { Component } from "@angular/core";
import { Recipe } from "./recipe";
import { RecipeService } from "./recipe.service";
import { OnInit } from "@angular/core";

@Component({
  selector: "recipes",
  templateUrl: "./recipe.component.html" ,
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
