import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 't3lmy',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44384/',
    redirectUri: baseUrl,
    clientId: 't3lmy_App',
    responseType: 'code',
    scope: 'offline_access t3lmy',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44384',
      rootNamespace: 't3lmy',
    },
  },
} as Environment;
