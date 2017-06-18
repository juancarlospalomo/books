import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RecipeDetailComponent } from "./recipe-detail.component";
import { AppComponent } from "./app.component";
import { RecipeService } from "./recipe.service";

@NgModule({
  declarations: [AppComponent, RecipeDetailComponent],
  imports: [BrowserModule, FormsModule],
  providers: [RecipeService],
  bootstrap: [AppComponent]
})
export class AppModule {}
