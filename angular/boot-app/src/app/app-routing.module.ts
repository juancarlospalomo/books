import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { DashboardComponent } from "./dashboard.component";
import { RecipeComponent } from "./recipe.component";
import { RecipeDetailComponent } from "./recipe-detail.component";

const routes: Routes = [
  {
    path: "recipes",
    component: RecipeComponent
  },
  {
    path: "dashboard",
    component: DashboardComponent
  },
  {
    path: "",
    redirectTo: "/dashboard",
    pathMatch: "full"
  },
  {
    path: "detail/:id",
    component: RecipeDetailComponent
  }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}
