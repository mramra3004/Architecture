import { OptionModel } from "../option.model";
import { AppSelectComponent } from "../select.component";

@Component({
    providers: [{ provide: NG_VALUE_ACCESSOR, useExisting: AppSelectCommentComponent, multi: true }],
    selector: "app-select-comment",
    templateUrl: "../select.component.html"
})
export class AppSelectCommentComponent extends AppSelectComponent {
    constructor(private readonly http: HttpClient) { super(); }

    getOptions(postId: number): Observable<OptionModel[]> {
        if (!postId) {
            return of();
        }

        return this.http
            .get(`https://jsonplaceholder.typicode.com/comments?postId=${postId}`)
            .pipe(flatMap((x: any) => x), map((x: any) => new OptionModel(x.id, x.name)), toArray());
    }
}
