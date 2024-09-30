export const checkAdminStatus = () => {
  const token = localStorage.getItem('accessToken');

  if (!token) {
    console.log('Cannot find token');
    return false;
  }

  try {
    const decodedToken = decodeToken(token);
    

    if (isTokenExpired(decodedToken)) {
      console.warn('Token expired');
      return false;
    }
    
    return isAdminOrTeacher(decodedToken.role);
  } catch (error) {
    return false;
  }
};


const decodeToken = (token) => {
  const base64Url = token.split('.')[1];
  const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
  const jsonPayload = decodeURIComponent(atob(base64).split('').map(c => 
    '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2)
  ).join(''));
  return JSON.parse(jsonPayload);
};


const isTokenExpired = (decodedToken) => {
  return decodedToken.exp && decodedToken.exp < Date.now() / 1000;
};


const isAdminOrTeacher = (role) => {
  const result = role === 'admin' || role === 'teacher';
  console.log('Có quyền truy cập:', result);
  return result;
};
