import { AppModalService } from "../services/modal.service";

@Injectable({ providedIn: "root" })
export class AppErrorHandler implements ErrorHandler {
    constructor(private readonly injector: Injector) { }

    handleError(error: any) {
        if (error instanceof HttpErrorResponse) {
            switch (error.status) {
                case 401:
                    {
                        const router = this.injector.get<Router>(Router);
                        router.navigate(["/login"]);
                        return;
                    }
                case 422:
                    {
                        const appModalService = this.injector.get<AppModalService>(AppModalService);
                        appModalService.alert(error.error);
                        return;
                    }
            }
        }

        console.error(error);
    }
}
