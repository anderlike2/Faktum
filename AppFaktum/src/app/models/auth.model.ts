export interface IResAuthToken {
  isAuthSuccessful: boolean;
  errorMessage: string;
  token: string;
  tokenType: string;
  expiresIn: string;
}
