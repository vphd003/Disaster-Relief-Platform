// Khai báo lại cái URL trỏ về Backend C#
const BASE_URL = 'https://localhost:7000/api';

/**
 * Gọi API Đăng ký người dùng mới
 */
export async function registerUser(userData) {
  const response = await fetch(`${BASE_URL}/auth/register`, {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
    },
    body: JSON.stringify(userData),
  });
  if (!response.ok) {
    const errorData = await response.json().catch(() => ({}));
    throw new Error(errorData.message || `Lỗi server: ${response.status}`);
  }

  return response.json(); 
}