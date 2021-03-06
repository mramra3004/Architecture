import { OptionModel } from "../option.model";
import { AppSelectComponent } from "../select.component";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: AppSelectPostComponent, multi: true }],
    selector: "app-select-post",
    templateUrl: "../select.component.html"
})
export class AppSelectPostComponent extends AppSelectComponent {
    constructor(private readonly http: HttpClient) { super(); }

    getOptions(userId: number): Observable<OptionModel[]> {
        if (!userId) {
            return of();
        }

        return this.http
            .get(`https://jsonplaceholder.typicode.com/posts?userId=${userId}`)
            .pipe(flatMap((x: any) => x), map((x: any) => new OptionModel(x.id, x.title)), toArray());
    }
}
