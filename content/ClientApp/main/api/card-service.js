import * as httpService from './http-service';

export const getCard = id => {
  const cardUrl = '/api/CardApi/Get/' + id;
  return httpService.getData(cardUrl);
}

export const getAll = data => {
  const cardUrl = '/api/CardApi/GetAll/';
  return httpService.getData(cardUrl);
}