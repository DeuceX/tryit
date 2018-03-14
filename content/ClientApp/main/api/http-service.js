import axios from "axios";

let getHeaders = () => {
    let token = localStorage.getItem("token");
    let headers = {};

    if (token) {
        headers = {
            headers: { Authorization: `Bearer ${localStorage.token}` }
        };
    }

    return headers;
};

export const getData = url => {
    const headers = getHeaders();
    return axios.get(url, headers);
};

export const postData = params => {
    const headers = getHeaders();
    return axios.post(params.url, params.data, headers);
};
