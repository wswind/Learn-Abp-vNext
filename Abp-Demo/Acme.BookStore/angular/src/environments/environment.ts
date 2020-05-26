export const environment = {
  production: false,
  application: {
    name: 'BookStore',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44367',
    clientId: 'BookStore_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'BookStore',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44367'
    }
  },
  localization: {
    defaultResourceName: 'BookStore'
  }
};
