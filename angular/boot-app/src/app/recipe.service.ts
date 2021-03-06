import { Injectable } from "@angular/core";
import { Recipe } from "./recipe";
import { RECIPES } from "../mock/mock-recipes";

@Injectable()
export class RecipeService {
  getRecipes(): Promise<Recipe[]> {
/*    return new Promise(resolve => {
      setTimeout(() => resolve(RECIPES), 0);
    });*/
    return new Promise(resolve => resolve(RECIPES));
  }

  getRecipe(id: number): Promise<Recipe> {
    return this.getRecipes().then(recipes =>
      recipes.find(recipe => recipe.id == id)
    );
  }
}
