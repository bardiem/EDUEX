
export function parseError(errorObj): string[] {
    let errorMsgs = [];
    let errors = errorObj.error.errors;

    for (const key in errors) {
        let error = errors[key];

        if (Array.isArray(error)) {
            error.map(item => errorMsgs.push(item));
        } else {
            errorMsgs.push(error);
        }
    }

    return errorMsgs;
}