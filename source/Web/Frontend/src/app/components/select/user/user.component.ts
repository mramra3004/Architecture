import { OptionModel } from "../option.model";
import { AppSelectComponent } from "../select.component";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: AppSelectUserComponent, multi: true }],
    selector: "app-select-user",
    templateUrl: "../select.component.html"
})
export class AppSelectUserComponent extends AppSelectComponent {
    constructor(private readonly http: HttpClient) { super(); }

    getOptions(_: any): Observable<OptionModel[]> {
        return this.http
            .get("https://jsonplaceholder.typicode.com/users")
            .pipe(flatMap((x: any) => x), map((x: any) => new OptionModel(x.id, x.name)), toArray());
    }
}
