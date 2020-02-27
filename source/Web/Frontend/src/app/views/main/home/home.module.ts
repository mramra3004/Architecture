import { AppHomeComponent } from "./home.component";

const routes: Routes = [
    { path: "", component: AppHomeComponent }
];

@NgModule({
    declarations: [AppHomeComponent],
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [RouterModule]
})
export class AppHomeModule {
}
