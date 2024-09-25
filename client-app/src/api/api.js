
import axios from "axios";
import { useNavigate } from "react-router-dom";

const api = axios.create({
  baseURL: "https://localhost:7284/api", // URL gốc cho tất cả các request
  headers: {
    "Content-Type": "application/json",
  },
});

// Middleware để thêm token vào header trước mỗi request
api.interceptors.request.use(
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

// Middleware để xử lý lỗi response từ server
api.interceptors.response.use(
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

export default api;
