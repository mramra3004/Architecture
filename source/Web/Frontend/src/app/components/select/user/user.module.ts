import { AppSelectUserComponent } from "./user.component";

@NgModule({
    declarations: [
        AppSelectUserComponent
    ],
    exports: [
        AppSelectUserComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        ReactiveFormsModule
    ]
})
export class AppSelectUserModule {
}
