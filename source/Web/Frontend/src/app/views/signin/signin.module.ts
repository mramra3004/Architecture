import { AppButtonModule } from "./src/app/components/button/button.module";
import { AppInputPasswordModule } from "./src/app/components/input/password/password.module";
import { AppInputTextModule } from "./src/app/components/input/text/text.module";
import { AppLabelModule } from "./src/app/components/label/label.module";
import { AppSignInComponent } from "./signin.component";

const routes: Routes = [
    { path: "", component: AppSignInComponent }
];

@NgModule({
    declarations: [AppSignInComponent],
    imports: [
        CommonModule,
        ReactiveFormsModule,
        RouterModule.forChild(routes),
        AppButtonModule,
        AppInputPasswordModule,
        AppInputTextModule,
        AppLabelModule
    ],
    exports: [RouterModule]
})
export class AppSignInModule {
}
