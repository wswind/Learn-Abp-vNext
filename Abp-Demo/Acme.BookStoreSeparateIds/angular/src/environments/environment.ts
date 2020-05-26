export const environment = {
  production: false,
  application: {
    name: 'BookStoreSeparateIds',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44330',
    clientId: 'BookStoreSeparateIds_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'BookStoreSeparateIds',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44381'
    }
  },
  localization: {
    defaultResourceName: 'BookStoreSeparateIds'
  }
};
