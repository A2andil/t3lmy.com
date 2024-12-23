import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'com',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44327/',
    redirectUri: baseUrl,
    clientId: 'com_App',
    responseType: 'code',
    scope: 'offline_access com',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44327',
      rootNamespace: 't3lmy.com',
    },
  },
} as Environment;
