import axios from "axios";

const BASE_URL = "https://localhost:7284/api";

const AxiosAPI = axios.create({
  baseURL: BASE_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

AxiosAPI.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("accessToken");
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

AxiosAPI.interceptors.response.use(
  (response) => {
    return response;
  },
  (error) => {
    if (error.response && error.response.status === 401) {
      alert("Your account is not authorized.");
    }
    return Promise.reject(error);
  }
);

const api = {
  get: (url) => AxiosAPI.get(url),
  post: (url, data) => AxiosAPI.post(url, data),
  put: (url, data) => AxiosAPI.put(url, data),
  delete: (url) => AxiosAPI.delete(url),
  patch: (url, data) => AxiosAPI.patch(url, data),
};

export { BASE_URL };
export default api;
