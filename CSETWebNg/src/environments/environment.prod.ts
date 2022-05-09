////////////////////////////////
//
//   Copyright 2022 Battelle Energy Alliance, LLC
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
//
////////////////////////////////
export const environment = {
  production: true,
  appUrl: 'https://st-cset-ui-dev.azurewebsites.net',
  apiBaseUrl: 'https://st-cset-api-dev.azurewebsites.net',
  apiUrl: 'https://st-cset-api-dev.azurewebsites.net/api',
  analyticsUrl: '',
  docUrl: 'https://st-cset-api-dev.azurewebsites.net/Documents',
  reportsUrl: 'https://st-cset-reports-dev.azurewebsites.net',
  redirectUrl: 'https://st-cset-ui-dev.azurewebsites.net',
  loginScope: 'api://6150f740-1156-4d01-a911-1a7cc7ea74ec/.default',
  appCode: 'CSET',
  version: '11.0.1.3',
  helpContactEmail: '',
  helpContactPhone: '',
  azureAD: {
    clientId: '2029f083-bdbe-40f6-9954-dbfd3f7a12b4',
    loginAuthority: 'https://login.microsoftonline.com/e8c50350-42ca-4386-8486-9a5ad5f38406',
    scope: 'api://6150f740-1156-4d01-a911-1a7cc7ea74ec/.default',
    redirectUrl: 'http://localhost:4200',
  }
};
