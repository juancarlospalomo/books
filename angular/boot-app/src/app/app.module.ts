import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RecipeDetailComponent } from "./recipe-detail.component";
import { AppComponent } from "./app.component";
import { RecipeService } from "./recipe.service";
import { RecipeComponent } from "./recipe.component";
import { RouterModule } from "@angular/router";
import { DashboardComponent } from "./dashborard.component";

@NgModule({
  declarations: [
    AppComponent,
    RecipeComponent,
    RecipeDetailComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
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
    ])
  ],
  providers: [RecipeService],
  bootstrap: [AppComponent]
})
export class AppModule {}
