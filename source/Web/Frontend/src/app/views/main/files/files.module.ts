import { AppFileModule } from "./src/app/components/file/file.module";
import { AppFilesComponent } from "./files.component";

const routes: Routes = [
    { path: "", component: AppFilesComponent }
];

@NgModule({
    declarations: [AppFilesComponent],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule.forChild(routes),
        AppFileModule
    ],
    exports: [RouterModule]
})
export class AppFilesModule {
}
