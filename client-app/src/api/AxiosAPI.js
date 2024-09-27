import axios from "axios";
import { useNavigate } from "react-router-dom";

const AxiosAPI = axios.create({
  baseURL: "https://localhost:7284/api", 
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
      alert("Your session has expired. Please log in again.");
    }
    return Promise.reject(error);
  }
);

export default AxiosAPI;
