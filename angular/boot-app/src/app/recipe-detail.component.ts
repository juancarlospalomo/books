import { Component, Input, OnInit } from "@angular/core";
import { ActivatedRoute, Params } from "@angular/router";
import { Location } from "@angular/common";
import { Recipe } from "./recipe";
import { RecipeService } from "./recipe.service";
import "rxjs/add/operator/switchMap";

@Component({
  selector: "recipe-detail",
  templateUrl: "./recipe-detail.component.html"
})

export class RecipeDetailComponent implements OnInit {
  @Input() recipe: Recipe;

  constructor(
    private recipeService: RecipeService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.route.params
      .switchMap((params: Params) =>
        this.recipeService.getRecipe(+params["id"])
      )
      .subscribe(recipe => (this.recipe = recipe));
  }

  goBack(): void {
    this.location.back();
  }
}
