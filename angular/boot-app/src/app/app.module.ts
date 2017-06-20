import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RecipeDetailComponent } from "./recipe-detail.component";
import { AppComponent } from "./app.component";
import { RecipeService } from "./recipe.service";
import { RecipeComponent } from "./recipe.component";
import { RouterModule } from "@angular/router";
import { DashboardComponent } from "./dashborard.component";
import { AppRoutingModule } from "./app-routing.module";
import { MdToolbarModule, MdIconModule } from "@angular/material";

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
    MdToolbarModule,
    AppRoutingModule
  ],
  providers: [RecipeService],
  bootstrap: [AppComponent]
})
export class AppModule {}
