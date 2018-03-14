import * as httpService from './http-service';

export const getUserInfo = id => {
    const cardUrl = '/api/CardApi/Get/' + id;
    return httpService.getData(cardUrl);
}
